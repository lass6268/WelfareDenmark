document.onclick = function(event) {
  var dropdownmenu = document.getElementById("dropdownmenu");
  if (event.target != dropdownmenu) {
    document.getElementById("right-menuicon").classList.remove("change")
    document.getElementById("myDropdown").classList.remove("show")
  }
}

function toggleDropDownMenu() {
  changeMenuIcon();
  myFunction();
}

function changeMenuIcon() {
    document.getElementById("right-menuicon").classList.toggle("change")
}

/* When the user clicks on the button,
toggle between hiding and showing the dropdown content */

function myFunction() {
    document.getElementById("myDropdown").classList.toggle("show");
}

window.onload = function functionName() {
    document.getElementById("dropdown-menu-button").addEventListener('click', toggleDropDownMenu)
}

// Get the modal
var modal = document.getElementById('signup-form');

// When the user clicks anywhere outside of the modal, close it
document.onclick = function(event) {
   if (event.target == modal) {
       modal.style.display = "none";
   }
}