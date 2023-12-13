const student={
    firstName:"Ahmed",
    lastName:"Ahmedov",
    speciality:"Applied Programming",
    theClass:"12a",
    name:function(){
        return this.firstName+" "+this.lastName
    },
    print:function(){
        return student.name()+" "+this.theClass+" "+this.speciality
    }
}
document.getElementById("Name").innerHTML=student.name()
document.getElementById("Print").innerHTML=student.print()