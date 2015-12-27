CREATE DEFINER=`root`@`localhost` TRIGGER `expressdata`.`employee_BEFORE_DELETE` 
BEFORE DELETE ON `employee` 
FOR EACH ROW
BEGIN
	UPDATE `transport` 
    SET `person_id` = 1
    WHERE `person_id` IN
		(SELECT `employee_id`
		 FROM `employee_transport`
		 WHERE `charge` = 1 AND old.employee_id = `employee_transport`.`employee_id`);
    
    UPDATE `employee_transport` 
    SET `employee_transport`.`employee_id` = 1
    WHERE old.employee_id = `employee_transport`.`employee_id`;
END
