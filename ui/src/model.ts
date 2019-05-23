export interface Storyboard {
    epics: Epic[];
    releases: Release[];
}

export interface Epic {
    id: string;
    name: string;
    steps: Step[];
}

export interface Step {
    id: string;
    name: string;
    tasksPerRelease: TasksPerRelease[];
}

export interface TasksPerRelease {
    releaseId: string;
    tasks: Task[];
}

export interface Task {
    id: string;
    name: string;
}

export interface Release {
    id: string;
    name: string;
}
