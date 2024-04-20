DELIMITER $$
CREATE FUNCTION map_branch_id_to_name(
  branch_id INT
)RETURNS VARCHAR(60)
READS SQL Data
BEGIN
	DECLARE branch VARCHAR(60) DEFAULT NULL;
    SELECT program_name pn INTO branch 
    FROM programs WHERE program_id = branch_id;   
RETURN branch;
END  $$
DELIMITER ;