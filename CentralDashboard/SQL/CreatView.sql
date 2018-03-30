Create view LogSum as
select TopicName,
       count(TopicName) TopicCount, 
       max(datestamp) LastData 
from LogsDB
group by TopicName



select * from LogSum