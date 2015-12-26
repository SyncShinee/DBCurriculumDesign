CREATE DEFINER=`root`@`localhost` PROCEDURE `ADD_TRANSPORT`(IN id INT)
BEGIN
	UPDATE `order`
	SET `order_count` = `order_count` + 1
	WHERE `order_id` IN
		(SELECT dISTINCT `orderid` 
         FROM `goods` 
         WHERE `goods_id` IN
			(SELECT `goods_id` 
             FROM `transport_goods` 
             WHERE `transport_id` = id));
             
	UPDATE `order` 
    SET `order_state` = 1 
    WHERE `order_state` = 0 AND `order_count` IN 
		(SELECT dISTINCT `orderid` 
         FROM `goods` 
         WHERE `goods_id` IN
			(SELECT `goods_id` 
             FROM `transport_goods` 
             WHERE `transport_id` = id));
END