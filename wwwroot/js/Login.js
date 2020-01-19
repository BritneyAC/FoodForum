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
        document.querySelector('#UsernameMsg').innerHTML = (res);
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
        document.querySelector('#LoginUsernameMsg').innerHTML = (res);
      })
    }, 600);
    return false;
  })
})

// const Username = document.querySelector("#Username"),
//       LoginUsername = document.querySelector("#LoginUsername");

// let timeout = null;
// Username.addEventListener("keyup", () => {
//   clearTimeout(timeout);
//   let data = `Username=${Username.value}`;
//   timeout = setTimeout(() => {
//     let xhr = new XMLHttpRequest();
//     xhr.open("GET", PartialUrls.Username, true);
//     xhr.setRequestHeader('Content-type', 'application/x-www-form-urlencoded');
//     xhr.onload = () => {
//       console.log("hi");
//       if(xhr.status == 200){
//         document.querySelector("#UsernameMsg").innerHTML = xhr.responseText;
//       }
//     }
//     xhr.send(data);
//   }, 600);
// })
