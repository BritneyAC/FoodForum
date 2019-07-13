﻿$(document).ready(function(){
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
  $(document).on('click','#IndexRating',function(){
    $('#Sorting').load(PartialUrls.IndexRating)
    return false;
  })
  $(document).on('click','#UserRating',function(){
    $('#Sorting').load(PartialUrls.UserRating)
    return false;
  })
  $(document).on('click','#IndexRatingReverse',function(){
    $('#Sorting').load(PartialUrls.IndexRatingReverse)
    return false;
  })
  $(document).on('click','#UserRatingReverse',function(){
    $('#Sorting').load(PartialUrls.UserRatingReverse)
    return false;
  })
  $(document).on('click','#IndexLikes',function(){
    $('#Sorting').load(PartialUrls.IndexLikes)
    return false;
  })
  $(document).on('click','#UserLikes',function(){
    $('#Sorting').load(PartialUrls.UserLikes)
    return false;
  })
  $(document).on('click','#IndexLikesReverse',function(){
    $('#Sorting').load(PartialUrls.IndexLikesReverse)
    return false;
  })
  $(document).on('click','#UserLikesReverse',function(){
    $('#Sorting').load(PartialUrls.UserLikesReverse)
    return false;
  })
  $(document).on('click','#IndexTime',function(){
    $('#Sorting').load(PartialUrls.IndexTime)
    return false;
  })
  $(document).on('click','#IndexTimeReverse',function(){
    $('#Sorting').load(PartialUrls.IndexTimeReverse)
    return false;
  })
  $(document).on('click','#UserTime',function(){
    $('#Sorting').load(PartialUrls.UserTime)
    return false;
  })
  $(document).on('click', '#UserTimeReverse', function(){
    $('#Sorting').load(PartialUrls.UserTimeReverse)
    return false;
  })
})
