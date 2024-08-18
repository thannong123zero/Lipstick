using API.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SharedLibrary.UserInterfaceDTO;

namespace API.Controllers
{
    [Route("api/Topic")]
    [ApiController]
    public class TopicController : ControllerBase
    {
        private readonly TopicHelper _topicHelper;
        public TopicController(TopicHelper topicHelper)
        {
            _topicHelper = topicHelper;
        }
        [HttpGet]
        [Route("getTopics")]
        public async Task<IActionResult> GetTopics()
        {
            IEnumerable<TopicUI> data = await _topicHelper.GetTopics();
            if (data == null)
            {
                return BadRequest();
            }
            await _topicHelper.GetTopics();
            return Ok(data);
        }
        [HttpGet]
        [Route("getTopicByID")]
        public async Task<IActionResult> GetTopicByID(string ID)
        {
            TopicUI data = await _topicHelper.GetTopicByID(ID);
            if (data == null)
            {
                return BadRequest();
            }
            return Ok(data);
        }
        [HttpPost]
        [Route("addTopic")]
        public async Task<IActionResult> AddTopic([FromBody] TopicUI model)
        {
            if (model == null)
            {
                return BadRequest();
            }
            await _topicHelper.AddTopic(model);
            return Ok();
        }
        [HttpPut]
        [Route("updateTopic")]
        public async Task<IActionResult> UpdateTopic([FromBody] TopicUI model)
        {
            if (model == null)
            {
                return BadRequest();
            }
            await _topicHelper.UpdateTopic(model);

            return Ok();
        }
        [HttpDelete]
        [Route("deleteTopic")]
        public async Task<IActionResult> DeleteTopicByID(string ID)
        {
            if (ID == null)
            {
                return BadRequest();
            }
            await _topicHelper.DeleteTopicByID(ID);
            return Ok();
        }
        [HttpGet]
        [Route("checkPermissionToDelete")]
        public async Task<IActionResult> CheckPermissionToDelete(string ID)
        {
            DatabaseOjectResult databaseOjectResult = new DatabaseOjectResult();
            databaseOjectResult.OK = await _topicHelper.CheckPermissionToDelete(ID);
            return Ok(databaseOjectResult);
        }
        [HttpDelete]
        [Route("softDeleteTopic")]
        public async Task<IActionResult> SoftDeleteTopicByID(string ID)
        {
            if (ID == null)
            {
                return BadRequest();
            }
            await _topicHelper.SoftDeleteTopicByID(ID);

            return Ok();
        }
        [HttpPatch]
        [Route("restoreTopic")]
        public async Task<IActionResult> RestoreTopicByID(string ID)
        {
            if (ID == null)
            {
                return BadRequest();
            }
            await _topicHelper.RestoreTopicByID(ID);

            return Ok();
        }
    }
}
