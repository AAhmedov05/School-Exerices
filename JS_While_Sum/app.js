let answer=FindSum()

function FindSum()
{
    let n=prompt("Enter n:")
    let s=29/7;
    while(n>15)
    {
        s=s+(n/7)
        n--;
    }
    return s
}

document.getElementById("output").innerHTML="Answer "+answer;
