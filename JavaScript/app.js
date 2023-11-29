function TheX()
{
    var x=prompt("Enter the x:");
    if(x<5)
    {
        var y=x*10;
        document.write("y="+y);
    }
    if(x>=5)
    {
        y=10*Math.pow(x,2);
        document.write("y="+y);
    }
}
TheX();
function theFruits(){
let type=prompt("Enter the type:");
switch(type)
{
    case Fruits:
        let fruits=prompt("Fruit");
        if(fruits=="krusa")
        {
            document.write("Kursa Cena:2.80");
        }
        else
        {
            document.write("Qbilka Cena:3.20");
        };break;
    case Vegetables:
        let vege=prompt("Fruit");
        if(vege=="zele")
        {
            document.write("Zele Cena:4");
        }
        else
        {
            document.write("Domati Cena:5.80");
        };break;

    }    
}
theFruits();
