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
        $('#UsernameMsg').html(res)
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
        $('#LoginUsernameMsg').html(res)
      })
    }, 600);
    return false;
  })
  $('#RecipeTitle').keyup(() => {
    clearTimeout(timeout);
    var data = $("#RecipeTitle").serialize()
    timeout = setTimeout(() => {
      $.ajax({
        method: "GET",
        url: PartialUrls.RecipeTitle,
        data: data
      })
      .done((res) => {
        $('#RecipeTitleMsg').html(res)
      })
    }, 600);
    return false;
  })
  $('#UserRecipeTitle').keyup(() => {
    clearTimeout(timeout);
    var data = $("#UserRecipeTitle").serialize()
    timeout = setTimeout(() => {

      $.ajax({
        method: "GET",
        url: PartialUrls.UserRecipeTitle,
        data: data
      })
      .done((res) => {
        $('#UserRecipeTitleMsg').html(res)
      })
    }, 600);
    return false;
  })
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
  $(document).on('click', '.IngredientFourBtn', () => {
    $('.IngredientFourBtn').hide();
    $('#IngredientFourShow').show();
    return false;
  })
  $(document).on('keyup', '#IngredientThree', function(event){
    $('.')
  })
  $(document).on('click', '.IngredientFiveBtn', () => {
    $('.IngredientFiveBtn').hide();
    $('#IngredientFiveShow').show();
    return false;
  })
  $(document).on('click', '.IngredientSixBtn', () => {
    $('.IngredientSixBtn').hide();
    $('#IngredientSixShow').show();
    return false;
  })
  $(document).on('click', '.IngredientSevenBtn', () => {
    $('.IngredientSevenBtn').hide();
    $('#IngredientSevenShow').show();
    return false;
  })
  $(document).on('click', '.IngredientEightBtn', () => {
    $('.IngredientEightBtn').hide();
    $('#IngredientEightShow').show();
    return false;
  })
  $(document).on('click', '.IngredientNineBtn', () => {
    $('.IngredientNineBtn').hide();
    $('#IngredientNineShow').show();
    return false;
  })
  $(document).on('click', '.IngredientTenBtn', () => {
    $('.IngredientTenBtn').hide();
    $('#IngredientTenShow').show();
    return false;
  })
  $(document).on('click', '.IngredientElevenBtn', () => {
    $('.IngredientElevenBtn').hide();
    $('#IngredientElevenShow').show();
    return false;
  })
  $(document).on('click', '.IngredientTwelveBtn', () => {
    $('.IngredientTwelveBtn').hide();
    $('#IngredientTwelveShow').show();
    return false;
  })
  $(document).on('click', '.IngredientThirteenBtn', () => {
    $('.IngredientThirteenBtn').hide();
    $('#IngredientThirteenShow').show();
    return false;
  })
  $(document).on('click', '.IngredientFourteenBtn', () => {
    $('.IngredientFourteenBtn').hide();
    $('#IngredientFourteenShow').show();
    return false;
  })
  $(document).on('click', '.IngredientFifteenBtn', () => {
    $('.IngredientFifteenBtn').hide();
    $('#IngredientFifteenShow').show();
    return false;
  })
})