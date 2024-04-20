DELIMITER $$
CREATE PROCEDURE get_past_qualifaction(
	prn_number BIGINT
)
BEGIN 
	SELECT 
		education,
		university,
		institute_name,
		percentage,
		passing_year
		FROM past_qualification pq
		WHERE pq.prn_number = prn_number;
END $$
DELIMITER ;
