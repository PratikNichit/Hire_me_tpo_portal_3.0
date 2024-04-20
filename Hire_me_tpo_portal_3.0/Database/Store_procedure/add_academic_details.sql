DELIMITER $$
CREATE PROCEDURE add_academic_details(
	prn_number BIGINT,		
    pursuing_year INT,
    current_backlog TINYINT,
    dead_backlog TINYINT,
    current_cgpa DECIMAL(9,2),
    pursing_internship TINYINT,
    is_placed TINYINT
)
BEGIN
	INSERT INTO academics
    VALUES(	
		DEFAULT,
        prn_number,
        pursuing_year,
        current_backlog,
        dead_backlog,
        current_cgpa,
        pursing_internship,
        is_placed
	);
END$$
DELIMITER ; 