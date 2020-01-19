$(document).ready(() => {
  var timeout = null;
  $(document).on('click','#IndexRating',() => {
    $('#Sorting').load(PartialUrls.IndexRating)
    return false;
  })
  $(document).on('click','#UserRating',() => {
    $('#Sorting').load(PartialUrls.UserRating)
    return false;
  })
  $(document).on('click','#IndexRatingReverse',() => {
    $('#Sorting').load(PartialUrls.IndexRatingReverse)
    return false;
  })
  $(document).on('click','#UserRatingReverse',() => {
    $('#Sorting').load(PartialUrls.UserRatingReverse)
    return false;
  })
  $(document).on('click','#IndexLikes',() => {
    $('#Sorting').load(PartialUrls.IndexLikes)
    return false;
  })
  $(document).on('click','#UserLikes',() => {
    $('#Sorting').load(PartialUrls.UserLikes)
    return false;
  })
  $(document).on('click','#IndexLikesReverse',() => {
    $('#Sorting').load(PartialUrls.IndexLikesReverse)
    return false;
  })
  $(document).on('click','#UserLikesReverse',() => {
    $('#Sorting').load(PartialUrls.UserLikesReverse)
    return false;
  })
  $(document).on('click','#IndexTime',() => {
    $('#Sorting').load(PartialUrls.IndexTime)
    return false;
  })
  $(document).on('click','#IndexTimeReverse',() => {
    $('#Sorting').load(PartialUrls.IndexTimeReverse)
    return false;
  })
  $(document).on('click','#UserTime',() => {
    $('#Sorting').load(PartialUrls.UserTime)
    return false;
  })
  $(document).on('click', '#UserTimeReverse', () => {
    $('#Sorting').load(PartialUrls.UserTimeReverse)
    return false;
  })
})
// const Ajax = () => {
//   let xhr = new XMLHttpRequest();
//   xhr.open("GET", PartialUrls.IndexLikes, true);
//   xhr.onload = () => {
//     if(xhr.status == 200){
//       Sorting.innerHTML = xhr.responseText;
//     }
//   }
//   xhr.send();
// }
// var SortablesCount = 0;
// while (SortablesCount < 3){

//   const Sorting = document.querySelector("#Sorting");
//   if (document.querySelector("#IndexRating")){
//     IndexRating = document.querySelector("#IndexRating");
//     IndexRating.addEventListener("click", () => {
//       let xhr = new XMLHttpRequest();
//       xhr.open("GET", PartialUrls.IndexRating, true);
//       xhr.onload = () => {
//         if(xhr.status == 200){
//           Sorting.innerHTML = xhr.responseText;
//         }
//       }
//       xhr.send();
//       SortablesCount = 0;
//     });
//     SortablesCount++;
//   }
//   if (document.querySelector("#UserRating")){  
//     UserRating = document.querySelector("#UserRating");

//     UserRating.addEventListener("click", () => {
//       let xhr = new XMLHttpRequest();
//       xhr.open("GET", PartialUrls.UserRating, true);
//       xhr.onload = () => {
//         if(xhr.status == 200){
//           Sorting.innerHTML = xhr.responseText;
//         }
//       }
//       xhr.send();
//       SortablesCount = 0;
//     });
//     SortablesCount++;
//   }
//   if (document.querySelector("#IndexRatingReverse")){
//     IndexRatingReverse = document.querySelector("#IndexRatingReverse");
//     IndexRatingReverse.addEventListener("click", () => {
//       let xhr = new XMLHttpRequest();
//       xhr.open("GET", PartialUrls.IndexRatingReverse, true);
//       xhr.onload = () => {
//         if(xhr.status == 200){
//           Sorting.innerHTML = xhr.responseText;
//         }
//       }
//       xhr.send();
//       SortablesCount = 0;
//     });
//     SortablesCount++;
//   }
//   if (document.querySelector("#UserRatingReverse")){
//     UserRatingReverse = document.querySelector("#UserRatingReverse");
//     UserRatingReverse.addEventListener("click", () => {
//       let xhr = new XMLHttpRequest();
//       xhr.open("GET", PartialUrls.UserRatingReverse, true);
//       xhr.onload = () => {
//         if(xhr.status == 200){
//           Sorting.innerHTML = xhr.responseText;
//         }
//       }
//       xhr.send();
//       SortablesCount = 0;
//     });
//     SortablesCount++;
//   }
//   if (document.querySelector("#IndexLikes")){
//     IndexLikes = document.querySelector("#IndexLikes");
//     IndexLikes.addEventListener("click", () => {
//       let xhr = new XMLHttpRequest();
//       xhr.open("GET", PartialUrls.IndexLikes, true);
//       xhr.onload = () => {
//         if(xhr.status == 200){
//           Sorting.innerHTML = xhr.responseText;
//         }
//       }
//       xhr.send();
//       SortablesCount = 0;
//     });
//     SortablesCount++;
//   }
//   if (document.querySelector("#UserLikes")){
//   UserLikes = document.querySelector("#UserLikes");
//   UserLikes.addEventListener("click", () => {
//     let xhr = new XMLHttpRequest();
//     xhr.open("GET", PartialUrls.UserLikes, true);
//     xhr.onload = () => {
//       if(xhr.status == 200){
//         Sorting.innerHTML = xhr.responseText;
//       }
//     }
//     xhr.send();
//     SortablesCount = 0;
//   });
//   SortablesCount++;
//   }
//   if (document.querySelector("#IndexLikesReverse")){
//     IndexLikesReverse = document.querySelector("#IndexLikesReverse");
//     IndexLikesReverse.addEventListener("click", () => {
//       let xhr = new XMLHttpRequest();
//       xhr.open("GET", PartialUrls.IndexLikesReverse, true);
//       xhr.onload = () => {
//         if(xhr.status == 200){
//           Sorting.innerHTML = xhr.responseText;
//         }
//       }
//       xhr.send();
//       SortablesCount = 0;
//     });
//     SortablesCount++;
//   }
//   if (document.querySelector("#UserLikesReverse")){
//     UserLikesReverse = document.querySelector("#UserLikesReverse");
//     UserLikesReverse.addEventListener("click", () => {
//       let xhr = new XMLHttpRequest();
//       xhr.open("GET", PartialUrls.UserLikesReverse, true);
//       xhr.onload = () => {
//         if(xhr.status == 200){
//           Sorting.innerHTML = xhr.responseText;
//         }
//       }
//       xhr.send();
//       SortablesCount = 0;
//     });
//     SortablesCount++;
//   }
//   if (document.querySelector("#IndexTime")){
//     IndexTime = document.querySelector("#IndexTime");
//     IndexTime.addEventListener("click", () => {
//       let xhr = new XMLHttpRequest();
//       xhr.open("GET", PartialUrls.IndexTime, true);
//       xhr.onload = () => {
//         if(xhr.status == 200){
//           Sorting.innerHTML = xhr.responseText;
//         }
//       }
//       xhr.send();
//       SortablesCount = 0;
//     });
//     SortablesCount++;
//   }
//   if (document.querySelector("#IndexTimeReverse")){
//     IndexTimeReverse = document.querySelector("#IndexTimeReverse");
//     IndexTimeReverse.addEventListener("click", () => {
//       let xhr = new XMLHttpRequest();
//       xhr.open("GET", PartialUrls.IndexTimeReverse, true);
//       xhr.onload = () => {
//         if(xhr.status == 200){
//           Sorting.innerHTML = xhr.responseText;
//         }
//       }
//       xhr.send();
//       SortablesCount = 0;
//     });
//     SortablesCount++;
//   }
//   if (document.querySelector("#UserTime")){
//     UserTime = document.querySelector("#UserTime");
//     UserTime.addEventListener("click", () => {
//       let xhr = new XMLHttpRequest();
//       xhr.open("GET", PartialUrls.UserTime, true);
//       xhr.onload = () => {
//         if(xhr.status == 200){
//           Sorting.innerHTML = xhr.responseText;
//         }
//       }
//       xhr.send();
//       SortablesCount = 0;
//     });
//     SortablesCount++;
//   }
//   if (document.querySelector("#UserTimeReverse")){
//     UserTimeReverse = document.querySelector("#UserTimeReverse");
//     UserTimeReverse.addEventListener("click", () => {
//       let xhr = new XMLHttpRequest();
//       xhr.open("GET", PartialUrls.UserTimeReverse, true);
//       xhr.onload = () => {
//         if(xhr.status == 200){
//           Sorting.innerHTML = xhr.responseText;
//         }
//       }
//       xhr.send();
//       SortablesCount = 0;
//     });
//     SortablesCount++;
//   }
// }


