let BackToTop = document.querySelector("#BackToTop"),
      body = document.body,
      docElem = document.documentElement,
      offset = 100,
      scrollpos, docHeight;
  docHeight = Math.max(body.scrollHeight, body.offsetHeight, docElem.clientHeight, docElem.scrollHeight, docElem.offsetHeight);
  if ( docHeight != 'undefined' ){
    offset = docHeight / 8;
  }
  window.addEventListener( "scroll", ( event ) => {
    scrollPos = body.scrollTop || docElem.scrollTop;

    BackToTop.className = ( scrollPos > offset ) ? "visible" : "";
  } );
  