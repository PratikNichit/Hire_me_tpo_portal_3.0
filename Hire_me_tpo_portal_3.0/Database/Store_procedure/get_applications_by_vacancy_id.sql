DROP PROCEDURE IF EXISTS get_applications_by_vacancy_id;
DELIMITER $$
CREATE PROCEDURE get_applications_by_vacancy_id(
	id INT
)
BEGIN
	SELECT * FROM export_applcation_data WHERE vacany_id = 1;
END $$
DELIMITER ;