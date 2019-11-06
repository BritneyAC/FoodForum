$(document).ready(() => {
  var timeout = null;
  $('#Username').keyup(() => {
    clearTimeout(timeout);
    var data = $("#Username").serialize()
    timeout = setTimeout(() => {
      $.ajax({
        method: "GET",
        url: PartialUrls.Username,
        data: data
      })
      .done((res) => {
        $('#UsernameMsg').html(res)
      })
    }, 600);
    return false;
  })
  $('#LoginUsername').keyup(() => {
    clearTimeout(timeout);
    var data = $("#LoginUsername").serialize()
    timeout = setTimeout(() => {
      $.ajax({
        method: "GET",
        url: PartialUrls.LoginUsername,
        data: data
      })
      .done((res) => {
        $('#LoginUsernameMsg').html(res)
      })
    }, 600);
    return false;
  })
})