--Part 1
Id = Int;
Name = long;
EmployerId = Int;

--Part 2
Select name From employers
Where location = "St. Louis City";

--Part 3
SELECT *
FROM skills
INNER JOIN jobskills
ON skills.Id = jobskills.SkillId
ORDER BY skills.Name ASC;
