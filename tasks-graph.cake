#addin "Cake.Graph"

Task("Graph").Does(() => {
    Graph(Tasks)
        .Deploy(settings => {
            settings.IsWyam = true;
        });
});

BuildParameters.Tasks.PublishDocumentationTask
    .IsDependentOn("Graph");
BuildParameters.Tasks.PreviewDocumentationTask
    .IsDependentOn("Graph");
BuildParameters.Tasks.ForcePublishDocumentationTask
    .IsDependentOn("Graph");