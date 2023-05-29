$(document).ready(function () {
  // Load the navigation bar
  $("#navbar-placeholder").load("navbar.html");
});

$(document).ready(function () {
  $("#user-form").submit(function (event) {
    event.preventDefault();
    var name = $("#name").val();
    var email = $("#email").val();

    // Create a new row with user data
    var newRow = "<tr><td>" + name + "</td><td>" + email + "</td></tr>";

    // Append the new row to the table
    $("#user-table tbody").append(newRow);

    // Reset the form fields
    $("#name").val("");
    $("#email").val("");
  });
});
$(document).ready(function () {
  // Get initial balance
  var initialBalance = 2500;

  // Update balance in the paragraph
  $("#balance").text("$" + initialBalance);

  // Submit transaction form
  $("#transaction-form").submit(function (e) {
    e.preventDefault();

    // Get the entered amount
    var amount = parseFloat($("#amount").val());

    // Calculate the remaining balance
    var remainingBalance = initialBalance - amount;

    // Update the balance in the paragraph
    $("#balance").text("$" + remainingBalance.toFixed(2));

    // Add the transaction to the transaction history table
    var row =
      "<tr><td>$" +
      amount.toFixed(2) +
      "</td><td>$" +
      remainingBalance.toFixed(2) +
      "</td></tr>";
    $("#transaction-table tbody").append(row);

    // Reset the form
    $("#transaction-form")[0].reset();
  });
});
