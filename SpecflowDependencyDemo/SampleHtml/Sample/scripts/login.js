document
    .getElementById("login-form")
    .addEventListener("submit", function (event) {
        event.preventDefault();

        const username = document.getElementById("username").value;
        const password = document.getElementById("password").value;

        if (username === "admin" && password === "password") {
            // Redirect to Home Page
            sessionStorage.setItem("username", username);
            window.location.href = "../Sample/views/index.html";
        } else {
            alert("Invalid username or password");
        }
    });
