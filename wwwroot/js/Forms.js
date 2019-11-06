$(document).ready(() => {
  var timeout = null;
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
  $(document).on('click', '.IngredientFourBtn', () => {
    $('.IngredientFourBtn').hide();
    $('#IngredientFourShow').show();
    return false;
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