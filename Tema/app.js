const menu=document.getElementById("specialties")

menu.addEventListener("click",manageMenuClick)

function manageMenuClick(){
   document.getElementById("mainMenu").style.display="none"
   document.getElementById("menuSpecialties").style.display="flex"
}