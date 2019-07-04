$(document).ready(function(){
  var timeout = null;
  $('#Username').keyup(function(){
    clearTimeout(timeout);
    var data = $("#RegForm").serialize()
    timeout = setTimeout(function(){
      $.ajax({
        method: "POST",
        url: "/Username",
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
        url: "/LoginUsername",
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
        url: "/RecipeTitle",
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
        url: "/UserRecipeTitle",
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
      url: "/IndexRating",
    })
    .done(function(res){
      $('#Sorting').html(res)
    })
  })
  $('#UserRating').click(function(){
    $.ajax({
      method: "GET",
      url: "/UserRating",
    })
    .done(function(res){
      $('#Sorting').html(res)
    })
  })
  $('#IndexRatingReverse').click(function(){
    $.ajax({
      method: "GET",
      url: "/IndexRatingReverse",
    })
    .done(function(res){
      $('#Sorting').html(res)
    })
  })
  $('#UserRatingReverse').click(function(){
    $.ajax({
      method: "GET",
      url: "/UserRatingReverse",
    })
    .done(function(res){
      $('#Sorting').html(res)
    })
  })
  $('#IndexLikes').click(function(){
    $.ajax({
      method: "GET",
      url: "/IndexLikes",
    })
    .done(function(res){
      $('#Sorting').html(res)
    })
  })
  $('#UserLikes').click(function(){
    $.ajax({
      method: "GET",
      url: "/UserLikes",
    })
    .done(function(res){
      $('#Sorting').html(res)
    })
  })
  $('#IndexLikesReverse').click(function(){
    $.ajax({
      method: "GET",
      url: "/IndexLikesReverse",
    })
    .done(function(res){
      $('#Sorting').html(res)
    })
  })
  $('#UserLikesReverse').click(function(){
    $.ajax({
      method: "GET",
      url: "/UserLikesReverse",
    })
    .done(function(res){
      $('#Sorting').html(res)
    })
  })
  $('#IndexTime').click(function(){
    $.ajax({
      method: "GET",
      url: "/IndexTime",
    })
    .done(function(res){
      $('#Sorting').html(res)
    })
  })
  $('#IndexTimeReverse').click(function(){
    $.ajax({
      method: "GET",
      url: "/IndexTimeReverse",
    })
    .done(function(res){
      $('#Sorting').html(res)
    })
  })
  $('#UserTime').click(function(){
    $.ajax({
      method: "GET",
      url: "/UserTime",
    })
    .done(function(res){
      $('#Sorting').html(res)
    })
  })
  $('#UserTimeReverse').click(function(){
    $.ajax({
      method: "GET",
      url: "/UserTimeReverse",
    })
    .done(function(res){
      $('#Sorting').html(res)
    })
  })
})