const from=prompt("From which year")
const to=prompt("To which year")
var answer=Years(from,to)

function Years(from,to)
{
    var text=""
    let year=from
    while(year>=from&&year<to)
    {
        if(year%4==0)
        {
            text+="<br>Year "+year
        }
        year++;
    }
    return text
}

document.getElementById("output").innerHTML="<br>"+answer 