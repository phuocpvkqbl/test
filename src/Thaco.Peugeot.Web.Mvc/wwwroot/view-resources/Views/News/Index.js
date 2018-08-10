(function () {
	$(function () {

        var _newsService = abp.services.app.news;
		var _$modal = $('#NewsCreateModal');
		var _$form = _$modal.find('form');

		_$form.validate({
		});

		$('#RefreshButton').click(function () {
			refreshRoleList();
		});

        $('.delete-news').click(function () {
            var newsId = $(this).attr("data-news-id");

            deleteNews(newsId);
		});

        $('.edit-news').click(function (e) {
            var newsId = $(this).attr("data-news-id");

			e.preventDefault();
			$.ajax({
                url: abp.appPath + 'News/EditNewsModal?newsId=' + newsId,
				type: 'POST',
				contentType: 'application/html',
				success: function (content) {
					$('#NewsEditModal div.modal-content').html(content);
				},
				error: function (e) { }
			});
		});

		_$form.find('button[type="submit"]').click(function (e) {
			e.preventDefault();

			if (!_$form.valid()) {
				return;
			}

			var news = _$form.serializeFormToObject(); //serializeFormToObject is defined in main.js

			abp.ui.setBusy(_$modal);
            _newsService.create(news).done(function () {
				_$modal.modal('hide');
				location.reload(true); //reload page to see new role!
			}).always(function () {
				abp.ui.clearBusy(_$modal);
			});
		});

		_$modal.on('shown.bs.modal', function () {
			_$modal.find('input:not([type=hidden]):first').focus();
		});

		function refreshRoleList() {
			location.reload(true); //reload page to see new role!
		}

		function deleteNews(newsId) {
			abp.message.confirm(
                abp.utils.formatString(abp.localization.localize('AreYouSureWantToDelete', 'PhuocProjectTest'), ""),
				function (isConfirmed) {
					if (isConfirmed) {
						_newsService.delete({
                            id: newsId
						}).done(function () {
							refreshRoleList();
						});
					}
				}
			);
		}
	});
})();