DELIMITER $$
CREATE PROCEDURE add_past_qualifaction(
	prn_number BIGINT,
    education VARCHAR(70),
    university VARCHAR(70),
    institute_name VARCHAR(70),
    percentage DECIMAL(9,2),
    passing_year INT
)
BEGIN
	INSERT INTO past_qualification
    VALUES(DEFAULT,prn_number,education,university,institute_name,percentage,passing_year);
END $$
DELIMITER ;