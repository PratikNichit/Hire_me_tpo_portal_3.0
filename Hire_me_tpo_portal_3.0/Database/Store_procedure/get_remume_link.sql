DELIMITER $$
CREATE PROCEDURE get_remume_link(
	id BIGINT
)
BEGIN
	SELECT resume_link FROM student_info WHERE prn_number = id;
END $$
DELIMITER ;