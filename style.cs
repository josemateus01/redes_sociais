@import url('https://fonts.googleapis.com/css2?family=Nunito+Sans:ital,opsz,wght@0,200..1000;1,200..1000&display=swap&#39&#39');

:root{
--bg-color: #222831;
--primary-color: #DDDDDD;
--secundary-color: #F05454;
--font: 'Nunito Sans', sans-serif;
}

body {
background-color: var(--bg-color);
color: var(--primary-color);
font-family: var(--font);
height: 100vh;
margin: 0;
}
header{
background-color: var(--primary-color);
text-align: center;
padding: 1px;
}
h1{
font-size: 2rem;
color: var(--bg-color);
font-weight: 700;
}
nav {
display: flex;
justify-content: center;
font-weight: 400;
}

nav a {
text-decoration: none;
color: var(--bg-color);
margin: 0rem 2rem 3rem 0rem;
font-size: 1.2rem;
}
nav a:hover{
text-decoration: underline;
transform: scale(0.90);
transition: transform 0.1s;
}

footer{
display: flex;
align-items: center;
justify-content: center;
background-color: var(--primary-color);
color: var(--bg-color);
width: 100%;
height: 3rem;
margin-top: 2rem;
}