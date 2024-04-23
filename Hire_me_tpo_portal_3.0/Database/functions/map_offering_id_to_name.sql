DELIMITER $$
CREATE  FUNCTION `map_offering_id_to_name`(
  offering_id INT
) RETURNS VARCHAR(45)
    READS SQL DATA
BEGIN
	DECLARE name_return VARCHAR(45) DEFAULT NULL;
	SELECT name INTO name_return  FROM offering WHERE offering.offering_id = offering_id ;
    RETURN id;
END $$
DELIMITER ;