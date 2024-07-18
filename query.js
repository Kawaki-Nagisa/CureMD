$(document).ready(function() {
    var buttonText;
    $('#search-button').on('mouseenter', function() {
      buttonText = $(this).html();
      $(this).html(`
        <svg xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 24 24" stroke-width="1.5" stroke="currentColor" class="size-6">
          <path stroke-linecap="round" stroke-linejoin="round" d="m21 21-5.197-5.197m0 0A7.5 7.5 0 1 0 5.196 5.196a7.5 7.5 0 0 0 10.607 10.607Z" />
        </svg>
      `);
    }).on('mouseleave', function() {
      $(this).html(buttonText);
    });
  });

  $(document).ready(function() {
    $("#load-books").on("click", function() {
      var title = $(this).text(); // get the title of the button clicked
      $.ajax({
        type: "GET",
        url: "books.json", // assuming the JSON file is named "books.json" and is in the same directory as the HTML file
        dataType: "json",
        success: function(data) {
          // data is an array of book objects
          var book = $.grep(data, function(book) {
            return book.title === title;
          })[0]; // find the book with the matching title
          if (book) {
            var $bookCover = $("#book-cover");
            $bookCover.find("img").attr("src", book.image);
            $bookCover.find("h2").text(book.title);
            $bookCover.find("p.feature-text").text(book.description);
          }
        },
        error: function(xhr, status, error) {
          console.log("Error: " + error);
        }
      });
    });
  });