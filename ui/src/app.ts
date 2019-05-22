import "./styles/app.css";
import ko from 'knockout';

declare var TrelloPowerUp: any;

function sayHi() {
    const header = document.querySelector('h1');
    const template = `<div class="red">Hello from TypeScript</div>`
    header.insertAdjacentHTML("afterend" ,template);

    const vm = {
        koMsg: 'Hello from Knockout'
    }

    ko.applyBindings(vm);
}

document.addEventListener('DOMContentLoaded', sayHi, false);
