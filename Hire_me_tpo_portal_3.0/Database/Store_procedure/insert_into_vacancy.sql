DELIMITER $$
CREATE PROCEDURE `insert_into_vacancy`(
		company_name VARCHAR(50),
		job_location VARCHAR(50),
        no_of_vacancy INT,
        registation_start_date DATE,
        registation_end_date DATE,
        min_package DECIMAL(9,2),
        max_package DECIMAL(9,2),
        offering_id INT,
        dead_backlogs TINYINT,
        current_backlogs TINYINT,
        year_down TINYINT,
        pursuing_internship TINYINT,
        candidate_type VARCHAR(30),
        stipend_amound DECIMAL(9,2),
        min_cgpa DECIMAL(9,2),
        min_ssc_percentage DECIMAL(9,2),
        min_hsc_percentage DECIMAL(9,2),
        min_diploma_percentage DECIMAL(9,2),
        computer_science TINYINT,
        information_technology TINYINT,
        Artificial_Intelligence_and_Data_Science TINYINT,
        Artificial_Intelligence_and_machine_learning TINYINT,
        Electronics_and_telecommunication TINYINT,
        instrumentation TINYINT,
        production TINYINT,
        chemical TINYINT
)
BEGIN
	INSERT INTO vacancy(
		vacancy_id,
        comapny_id,
        job_location,
        no_of_vacancy,
        registation_start_date,
        registation_end_date,
        min_package,
        max_package,
        offering_id,
        dead_backlogs,
        current_backlogs,
        year_down,
        pursuing_internship,
        candidate_type,
        stipend_amound,
        min_cgpa,
        min_ssc_percentage,
        min_hsc_percentage,
        min_diploma_percentage
	)
    VALUES(
		DEFAULT,
        (SELECT company_id FROM compnay_info WHERE name = company_name),
        job_location,
        no_of_vacancy,
        registation_start_date,
        registation_end_date,
        min_package,
        max_package,
        map_offering_name_to_id(offering_id),
        dead_backlogs,
        current_backlogs,
        year_down,
        pursuing_internship,
        candidate_type,
        stipend_amound,
        min_cgpa,
        min_ssc_percentage,
        min_hsc_percentage,
        min_diploma_percentage
	);
    set @current_vacancy_id = last_insert_id();
    
    INSERT INTO vacancy_details
    VALUES(
			DEFAULT,
            @current_vacancy_id,
            computer_science,
            information_technology,
            Artificial_Intelligence_and_Data_Science,
            Artificial_Intelligence_and_machine_learning,
            Electronics_and_telecommunication,
            instrumentation,
            production,
            chemical
	);
    
	UPDATE vacancy SET vacancy_detail_id = last_insert_id() WHERE vacancy_id = @current_vacancy_id;
END $$
DELIMITER ;