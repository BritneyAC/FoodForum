$(document).ready(function(){
  var timeout = null;
  $('#Username').keyup(function(){
    clearTimeout(timeout);
    var data = $("#RegForm").serialize()
    timeout = setTimeout(function(){
      $('#Sorting').load(PartialUrls.Username, Username)
    }, 600);
  })
  $('#LoginUsername').keyup(function(){
    clearTimeout(timeout);
    var data = $("#LoginForm").serialize()
    timeout = setTimeout(function(){
      $('#Sorting').load(PartialUrls.LogingUsername, Username)
    }, 600);
  })
  $('#RecipeTitle').keyup(function(){
    clearTimeout(timeout);
    var data = $("#RecipeTitle").serialize()
    timeout = setTimeout(function(){
      $('#Sorting').load(PartialUrls.RecipeTitle, Title)
    }, 600);
  })
  $('#UserRecipeTitle').keyup(function(){
    clearTimeout(timeout);
    var data = $("#UserRecipeTitle").serialize()
    timeout = setTimeout(function(){
      $('#Sorting').load(PartialUrls.UserRecipeTitle, Title)
    }, 600);
  })
  $('#IndexRating').click(function(){
    $('#Sorting').load(PartialUrls.IndexRating)
  })
  $('#UserRating').click(function(){
      $('#Sorting').load(PartialUrls.UserRating,)
  })
  $('#IndexRatingReverse').click(function(){
      $('#Sorting').load(PartialUrls.IndexRatingReverse)
  })
  $('#UserRatingReverse').click(function(){
    $('#Sorting').load(PartialUrls.UserRatingReverse)
  })
  $('#IndexLikes').click(function(){
    $('#Sorting').load(PartialUrls.IndexLikes)
  })
  $('#UserLikes').click(function(){
    $('#Sorting').load(PartialUrls.UserLikes)
  })
  $('#IndexLikesReverse').click(function(){
    $('#Sorting').load(PartialUrls.IndexLikesReverse)
  })
  $('#UserLikesReverse').click(function(){
    $('#Sorting').load(PartialUrls.UserLikesReverse)
  })
  $('#IndexTime').click(function(){
    $('#Sorting').load(PartialUrls.IndexTime)
  })
  $('#IndexTimeReverse').click(function(){
    $('#Sorting').load(PartialUrls.IndexTimeReverse)
  })
  $('#UserTime').click(function(){
    $('#Sorting').load(PartialUrls.UserTime)
  })
  $('#UserTimeReverse').click(function(){
    $('#Sorting').load(PartialUrls.UserTimeReverse)
  })
})