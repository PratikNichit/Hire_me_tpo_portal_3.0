CREATE OR REPLACE VIEW company_dashboard AS 
SELECT  
	name AS Company_Name,
    location AS Company_Location,	
    map_offering_id_to_name(offering_id) AS Offerings,
    min_package AS 	Minimum_Package,
    max_package AS Maximun_Package,
    about AS About
FROM company_info;
    