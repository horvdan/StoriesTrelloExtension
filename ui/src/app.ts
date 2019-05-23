import { getStoryboard } from './api';
import "./styles/app.css";
import ko from 'knockout';

declare var TrelloPowerUp: any;

async function app() {
    const storyboard = await getStoryboard();

    const epics = storyboard.epics;

    const vm = {
        epics
    }

    ko.applyBindings(vm);
}

app();
