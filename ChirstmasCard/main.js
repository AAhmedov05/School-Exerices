let imgBtn=document.getElementById("snow");
const snowFlakes = document.querySelectorAll(".snowflake")
imgBtn.addEventListener("click" , ()=>{
    snowFlakes.forEach((snowflake) => {snowflake.classList.add("snowFall")})
    setTimeout(()=>{
        document.querySelector("main").style.backgroundImage="url(Image/background2.jpg)"
        document.querySelector("main").classList.add("trans")
        let newYearText = document.createElement("h1")
        newYearText.textContent= "Happy new year"
        newYearText.classList.toggle("textStyle")
        newYearText.classList.toggle("trans")
        document.querySelector("main").appendChild(newYearText)
        const start=()=>{
            setTimeout(()=>{
                confetti.start();
            });
        };
        const stop=()=>{
            setTimeout(()=>{
                confetti.stop();
            });
        };
        start();
    },6500)})