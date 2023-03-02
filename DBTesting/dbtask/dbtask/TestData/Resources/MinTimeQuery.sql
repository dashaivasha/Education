SELECT test.name, proj.name as ProjectName, TIMESTAMPDIFF(second,start_time, end_time) as 'MinTime'
FROM union_reporting.test join union_reporting.project as proj on proj.id = test.project_id 
where 'MinTime' = (Select Min('MinTime'))
Order by proj.name, test.name;