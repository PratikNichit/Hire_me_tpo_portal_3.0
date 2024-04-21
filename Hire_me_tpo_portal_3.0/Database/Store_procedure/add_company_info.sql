DROP PROCEDURE IF EXISTS add_company_info;
DELIMITER $$
CREATE PROCEDURE add_company_info(
	industry_type VARCHAR(45),
    name VARCHAR(45),
    company_type VARCHAR(45),
    location VARCHAR(45),
    offerings VARCHAR(45),
    company_address VARCHAR(45),
    company_email_id VARCHAR(45),
    min_package DECIMAL(9,2),
    max_pachage DECIMAL(9,2),
    about VARCHAR(200)
)
BEGIN
	INSERT INTO company_info
    VALUES(
		DEFAULT,
        industry_type,
        name,
        company_type,
        location,
        map_offering_name_to_id(offerings),
        company_address,
        company_email_id,
        min_package,
        max_pachage,
        about
	);
END $$
DELIMITER ;