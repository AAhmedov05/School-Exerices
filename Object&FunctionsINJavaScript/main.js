const worker={
    firstName:"Ahmed",
    lastName:"Ahmedov",
    workedHoures:8,
    costForAnHour:100,
    print:function(){
        return this.firstName+" "+this.lastName+" worked money: "+this.workedHoures*this.costForAnHour
    },
    saved:function(){
        return this.firstName+" "+this.lastName+" saved money for day: "+ (this.workedHoures*this.costForAnHour*0.05)
    }
}
document.getElementById("Print").innerHTML=worker.print()
document.getElementById("Saved").innerHTML=worker.saved()
