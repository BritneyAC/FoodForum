$(document).ready(function(){
  var timeout = null;
  $('#Username').keyup(function(){
    clearTimeout(timeout);
    var data = $("#Username").serialize()
    timeout = setTimeout(function(){
      $.ajax({
        method: "GET",
        url: PartialUrls.Username,
        data: data
      })
      .done(function(res){
        $('#UsernameMsg').html(res)
      })
    }, 600);
    return false;
  })
  $('#LoginUsername').keyup(function(){
    clearTimeout(timeout);
    var data = $("#LoginUsername").serialize()
    timeout = setTimeout(function(){
      $.ajax({
        method: "GET",
        url: PartialUrls.LoginUsername,
        data: data
      })
      .done(function(res){
        $('#LoginUsernameMsg').html(res)
      })
    }, 600);
    return false;
  })
  $('#RecipeTitle').keyup(function(){
    clearTimeout(timeout);
    var data = $("#RecipeTitle").serialize()
    timeout = setTimeout(function(){
      $.ajax({
        method: "GET",
        url: PartialUrls.RecipeTitle,
        data: data
      })
      .done(function(res){
        $('#RecipeTitleMsg').html(res)
      })
    }, 600);
    return false;
  })
  $('#UserRecipeTitle').keyup(function(){
    clearTimeout(timeout);
    var data = $("#UserRecipeTitle").serialize()
    timeout = setTimeout(function(){

      $.ajax({
        method: "GET",
        url: PartialUrls.UserRecipeTitle,
        data: data
      })
      .done(function(res){
        $('#UserRecipeTitleMsg').html(res)
      })
    }, 600);
    return false;
  })
  $('#IndexRating').click(function(){
    $('#Sorting').load(PartialUrls.IndexRating)
    return false;
  })
  $('#UserRating').click(function(){
    $('#Sorting').load(PartialUrls.UserRating)
    return false;
  })
  $('#IndexRatingReverse').click(function(){
    $('#Sorting').load(PartialUrls.IndexRatingReverse)
    return false;
  })
  $('#UserRatingReverse').click(function(){
    $('#Sorting').load(PartialUrls.UserRatingReverse)
    return false;
  })
  $('#IndexLikes').click(function(){
    $('#Sorting').load(PartialUrls.IndexLikes)
    return false;
  })
  $('#UserLikes').click(function(){
    $('#Sorting').load(PartialUrls.UserLikes)
    return false;
  })
  $('#IndexLikesReverse').click(function(){
    $('#Sorting').load(PartialUrls.IndexLikesReverse)
    return false;
  })
  $('#UserLikesReverse').click(function(){
    $('#Sorting').load(PartialUrls.UserLikesReverse)
    return false;
  })
  $('#IndexTime').click(function(){
    $('#Sorting').load(PartialUrls.IndexTime)
    return false;
  })
  $('#IndexTimeReverse').click(function(){
    $('#Sorting').load(PartialUrls.IndexTimeReverse)
    return false;
  })
  $('#UserTime').click(function(){
    $('#Sorting').load(PartialUrls.UserTime)
    return false;
  })
  $('#UserTimeReverse').click(function(){
    $('#Sorting').load(PartialUrls.UserTimeReverse)
    return false;
  })
})