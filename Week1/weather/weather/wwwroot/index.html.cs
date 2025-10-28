< !DOCTYPE html >
< html lang = "en" >
< head >
  < meta charset = "UTF-8" />
  < meta name = "viewport" content = "width=device-width, initial-scale=1.0" />
  < title > Weather Finder </ title >
  < style >
    body { font - family: Arial; text - align: center; margin - top: 60px; }
    .btn { padding: 10px 20px; font - size: 16px; cursor: pointer; border - radius: 8px; border: none; background - color: #007bff; color: white; }
    .card { background: #f0f0f0; display: inline-block; padding: 20px; border-radius: 10px; margin-top: 20px; min-width: 250px; box-shadow: 0 2px 6px rgba(0,0,0,0.2); }
  </ style >
</ head >
< body >
  < h1 >🌦️ Live Weather App</h1>
  <button class= "btn" onclick = "askCity()" > Enter City </ button >

  < div id = "result" class= "card" ></ div >

  < script >
    async function askCity()
{
    const city = prompt("Enter city name:");
    if (!city) return;

    const response = await fetch(`/ api / weather / city ? city =${ city}`);
    const resultDiv = document.getElementById("result");

    if (!response.ok)
    {
        resultDiv.innerHTML = "❌ City not found or API error!";
        return;
    }

    const data = await response.json();
    resultDiv.innerHTML = `
        < h3 >${ data.city}</ h3 >
        < p >🌡️ Temperature: ${ data.temperature}</ p >
        < p >☁️ Condition: ${ data.condition}</ p >
        < p >💧 Humidity: ${ data.humidity}</ p >
        < p >🌬️ Wind Speed: ${ data.windSpeed}</ p >
      `;
    }
  </ script >
</ body >
</ html >
