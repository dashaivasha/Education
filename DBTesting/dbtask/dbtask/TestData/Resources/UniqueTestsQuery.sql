SELECT project.name as ProjectName, count(distinct test.name) as Count From test join project on test.project_id = project.id
group by project.name;