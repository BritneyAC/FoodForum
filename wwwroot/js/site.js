$(document).ready(function(){
  $('#Username').keyup(function(){
    var data = $("#RegForm").serialize()
    $.ajax({
      method: "POST",
      url: "/Username",
      data: data
    })
    .done(function(res){
      $('#UsernameMsg').html(res)
    })
  })
  $('#LoginUsername').keyup(function(){
    var data = $("#LoginForm").serialize()
    $.ajax({
      method: "POST",
      url: "/LoginUsername",
      data: data
    })
    .done(function(res){
      $('#LoginUsernameMsg').html(res)
    })
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
})