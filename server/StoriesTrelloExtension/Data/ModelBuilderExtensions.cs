using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using StoriesTrelloExtension.Data.Models;

public static class ModelBuilderExtensions
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        const int EPIC_COUNT = 4;
        const int RELEASE_COUNT = 2;
        const int MAX_STEPS_PER_EPIC = 5;

        // -- EPICS --
        var epics = Enumerable.Range(1, EPIC_COUNT).Select(num => new Epic
        {
            Id = num,
            Name = $"Epic {num}"
        }).ToList();

        // -- RELEASES --
        var releases = Enumerable.Range(1, RELEASE_COUNT).Select(num => new Release
        {
            Id = num,
            Name = $"Release {num}"
        }).ToList();


        // -- STEPS ---
        var steps = new List<object>();
        var stepId = 0;
        var rnd = new Random();

        // guarentees that each epic has to have atleast one step
        for (int i = 0; i < EPIC_COUNT; i++)
        {
            steps.AddRange(
                Enumerable.Range(1, rnd.Next(1, MAX_STEPS_PER_EPIC + 1))
                    .Select(num => new
                    {
                        Id = ++stepId,
                        Name = $"Step {stepId}",
                        EpicId = i+1
                    })
            );
        }

        // -- TASKS ---
        var tasks = Enumerable.Range(1, RELEASE_COUNT * steps.Count).Select(num => new
        {
            Id = num,
            Name = $"Task {num}",
            ReleaseId = rnd.Next(1, RELEASE_COUNT + 1),
            StepId = rnd.Next(1, steps.Count + 1)
        });


        modelBuilder.Entity<Epic>().HasData(epics);
        modelBuilder.Entity<Release>().HasData(releases);
        modelBuilder.Entity<Step>().HasData(steps);
        modelBuilder.Entity<Task>().HasData(tasks);
    }
}
