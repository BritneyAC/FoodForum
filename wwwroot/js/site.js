$(document).ready(function(){
  var timeout = null;
  $('#Username').keyup(function(){
    clearTimeout(timeout);
    var data = $("#RegForm").serialize()
    timeout = setTimeout(function(){
      $.ajax({
        method: "POST",
        url: RootUrl + "/Username",
        data: data
      })
      .done(function(res){
        $('#UsernameMsg').html(res)
      })
    }, 500);
  })
  $('#LoginUsername').keyup(function(){
    clearTimeout(timeout);
    var data = $("#LoginForm").serialize()
    timeout = setTimeout(function(){
      $.ajax({
        method: "POST",
        url: RootUrl + "/LoginUsername",
        data: data
      })
      .done(function(res){
        $('#LoginUsernameMsg').html(res)
      })
    }, 500);
  })
  $('#RecipeTitle').keyup(function(){
    clearTimeout(timeout);
    var data = $("#RecipeTitle").serialize()
    timeout = setTimeout(function(){
      $.ajax({
        method: "POST",
        url: RootUrl + "/RecipeTitle",
        data: data
      })
      .done(function(res){
        $('#RecipeTitleMsg').html(res)
      })
    }, 400);
  })
  $('#UserRecipeTitle').keyup(function(){
    clearTimeout(timeout);
    var data = $("#UserRecipeTitle").serialize()
    timeout = setTimeout(function(){

      $.ajax({
        method: "POST",
        url: RootUrl + "/UserRecipeTitle",
        data: data
      })
      .done(function(res){
        $('#UserRecipeTitleMsg').html(res)
      })
    }, 400);
  })
  $('#IndexRating').click(function(){
    $.ajax({
      method: "GET",
      url: RootUrl + "/IndexRating",
    })
    .done(function(res){
      $('#Sorting').html(res)
    })
  })
  $('#UserRating').click(function(){
    $.ajax({
      method: "GET",
      url: RootUrl + "/UserRating",
    })
    .done(function(res){
      $('#Sorting').html(res)
    })
  })
  $('#IndexRatingReverse').click(function(){
    $.ajax({
      method: "GET",
      url: RootUrl + "/IndexRatingReverse",
    })
    .done(function(res){
      $('#Sorting').html(res)
    })
  })
  $('#UserRatingReverse').click(function(){
    $.ajax({
      method: "GET",
      url: RootUrl + "/UserRatingReverse",
    })
    .done(function(res){
      $('#Sorting').html(res)
    })
  })
  $('#IndexLikes').click(function(){
    $.ajax({
      method: "GET",
      url: RootUrl + "/IndexLikes",
    })
    .done(function(res){
      $('#Sorting').html(res)
    })
  })
  $('#UserLikes').click(function(){
    $.ajax({
      method: "GET",
      url: RootUrl + "/UserLikes",
    })
    .done(function(res){
      $('#Sorting').html(res)
    })
  })
  $('#IndexLikesReverse').click(function(){
    $.ajax({
      method: "GET",
      url: RootUrl + "/IndexLikesReverse",
    })
    .done(function(res){
      $('#Sorting').html(res)
    })
  })
  $('#UserLikesReverse').click(function(){
    $.ajax({
      method: "GET",
      url: RootUrl + "/UserLikesReverse",
    })
    .done(function(res){
      $('#Sorting').html(res)
    })
  })
  $('#IndexTime').click(function(){
    $.ajax({
      method: "GET",
      url: RootUrl + "/IndexTime",
    })
    .done(function(res){
      $('#Sorting').html(res)
    })
  })
  $('#IndexTimeReverse').click(function(){
    $.ajax({
      method: "GET",
      url: RootUrl + "/IndexTimeReverse",
    })
    .done(function(res){
      $('#Sorting').html(res)
    })
  })
  $('#UserTime').click(function(){
    $.ajax({
      method: "GET",
      url: RootUrl + "/UserTime",
    })
    .done(function(res){
      $('#Sorting').html(res)
    })
  })
  $('#UserTimeReverse').click(function(){
    $.ajax({
      method: "GET",
      url: RootUrl + "/UserTimeReverse",
    })
    .done(function(res){
      $('#Sorting').html(res)
    })
  })
})