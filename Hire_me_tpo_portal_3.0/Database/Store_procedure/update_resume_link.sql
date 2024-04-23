DELIMITER $$
CREATE PROCEDURE update_resume_link(
 id BIGINT,
 link VARCHAR(500)
)
BEGIN
	UPDATE student_info SET resume_link = link WHERE prn_number = id; 
END $$
DELIMITER ;