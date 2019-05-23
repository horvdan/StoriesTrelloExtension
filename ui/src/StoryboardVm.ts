import { Storyboard, Step } from './model';

export class StoryboardVm {
    constructor(private storyboard: Storyboard) {}

    epics = this.storyboard.epics;

    releases = this.storyboard.releases;

    get steps(): Step[] {
        return [].concat.apply([], this.epics.map(e => e.steps));
    }

    tasksForRelease = (releaseId: string) => {
        const tasksPerReleases = this.steps.map(s => s.tasksPerRelease);
        const taskForThisRelease = tasksPerReleases.map(s => {
            const t = s.find(i => i.releaseId === releaseId);

            return t ? t.tasks : [];
        });

        return taskForThisRelease;
    }
}
