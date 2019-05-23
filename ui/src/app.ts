import ko from "knockout";
import { StoryboardVm } from './StoryboardVm';
import { getStoryboard } from "./api";
import "./styles/app.css";

async function app() {
  const storyboard = await getStoryboard();

  ko.applyBindings(new StoryboardVm(storyboard));
}

app();
