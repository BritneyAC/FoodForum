$(document).ready(function(){
  var timeout = null;
  $('#Username').keyup(function(){
    clearTimeout(timeout);
    var data = $("#RegForm").serialize()
    timeout = setTimeout(function(){
      $.ajax({
        method: "POST",
        url: PartialUrls.Username,
        data: data
      })
      .done(function(res){
        $('#UsernameMsg').html(res)
      })
    }, 600);
  })
  $('#LoginUsername').keyup(function(){
    clearTimeout(timeout);
    var data = $("#LoginForm").serialize()
    timeout = setTimeout(function(){
      $.ajax({
        method: "POST",
        url: PartialUrls.LoginUsername,
        data: data
      })
      .done(function(res){
        $('#LoginUsernameMsg').html(res)
      })
    }, 600);
  })
  $('#RecipeTitle').keyup(function(){
    clearTimeout(timeout);
    var data = $("#RecipeTitle").serialize()
    timeout = setTimeout(function(){
      $.ajax({
        method: "POST",
        url: PartialUrls.RecipeTitle,
        data: data
      })
      .done(function(res){
        $('#RecipeTitleMsg').html(res)
      })
    }, 600);
  })
  $('#UserRecipeTitle').keyup(function(){
    clearTimeout(timeout);
    var data = $("#UserRecipeTitle").serialize()
    timeout = setTimeout(function(){

      $.ajax({
        method: "POST",
        url: PartialUrls.UserRecipeTitle,
        data: data
      })
      .done(function(res){
        $('#UserRecipeTitleMsg').html(res)
      })
    }, 600);
  })
  $('#IndexRating').click(function(){
    $.ajax({
      method: "GET",
      url: PartialUrls.IndexRating,
    })
    .done(function(res){
      $('#Sorting').html(res)
    })
  })
  $('#UserRating').click(function(){
    $.ajax({
      method: "GET",
      url: PartialUrls.UserRating,
    })
    .done(function(res){
      $('#Sorting').html(res)
    })
  })
  $('#IndexRatingReverse').click(function(){
    $.ajax({
      method: "GET",
      url: PartialUrls.IndexRatingReverse,
    })
    .done(function(res){
      $('#Sorting').html(res)
    })
  })
  $('#UserRatingReverse').click(function(){
    $.ajax({
      method: "GET",
      url: PartialUrls.UserRatingReverse,
    })
    .done(function(res){
      $('#Sorting').html(res)
    })
  })
  $('#IndexLikes').click(function(){
    $.ajax({
      method: "GET",
      url: PartialUrls.IndexLikes,
    })
    .done(function(res){
      $('#Sorting').html(res)
    })
  })
  $('#UserLikes').click(function(){
    $.ajax({
      method: "GET",
      url: PartialUrls.UserLikes,
    })
    .done(function(res){
      $('#Sorting').html(res)
    })
  })
  $('#IndexLikesReverse').click(function(){
    $.ajax({
      method: "GET",
      url: PartialUrls.IndexLikesReverse,
    })
    .done(function(res){
      $('#Sorting').html(res)
    })
  })
  $('#UserLikesReverse').click(function(){
    $.ajax({
      method: "GET",
      url: PartialUrls.UserLikesReverse,
    })
    .done(function(res){
      $('#Sorting').html(res)
    })
  })
  $('#IndexTime').click(function(){
    $.ajax({
      method: "GET",
      url: PartialUrls.IndexTime,
    })
    .done(function(res){
      $('#Sorting').html(res)
    })
  })
  $('#IndexTimeReverse').click(function(){
    $.ajax({
      method: "GET",
      url: PartialUrls.IndexTimeReverse,
    })
    .done(function(res){
      $('#Sorting').html(res)
    })
  })
  $('#UserTime').click(function(){
    $.ajax({
      method: "GET",
      url: PartialUrls.UserTime,
    })
    .done(function(res){
      $('#Sorting').html(res)
    })
  })
  $('#UserTimeReverse').click(function(){
    $.ajax({
      method: "GET",
      url: PartialUrls.UserTimeReverse,
    })
    .done(function(res){
      $('#Sorting').html(res)
    })
  })
})