import "./styles/app.css";

function sayHi() {
    const header = document.querySelector('h1');
    const template = `<div class="red">Hello from TypeScript</div>`
    header.insertAdjacentHTML("afterend" ,template);
}

document.addEventListener('DOMContentLoaded', sayHi, false);
