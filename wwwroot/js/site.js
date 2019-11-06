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