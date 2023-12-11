const menu=document.getElementById("menu")

menu.addEventListener("click",manageMenuClick)

function manageMenuClick(){
   document.getElementById("mainMenu").style.display="none"
   document.getElementById("menuSpec").style.display="flex"
}