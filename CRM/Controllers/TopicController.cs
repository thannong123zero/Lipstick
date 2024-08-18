using CRM.Helpers;
using Microsoft.AspNetCore.Mvc;
using SharedLibrary.UserInterfaceDTO;

namespace CRM.Controllers
{
    public class TopicController : Controller
    {
        private readonly TopicHelper _topicHelper;
        public TopicController(TopicHelper topicHelper)
        {
            _topicHelper = topicHelper;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            IEnumerable<TopicUI> data = await _topicHelper.GetTopics();
            return View(data);
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            TopicUI model = new TopicUI();
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Create(TopicUI model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            await _topicHelper.CreateTopic(model);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> Update(string ID)
        {
            TopicUI data = await _topicHelper.GetTopicByID(ID);
            return View(data);
        }
        [HttpPost]
        public async Task<IActionResult> Update(TopicUI model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            await _topicHelper.UpdateTopic(model);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(string ID)
        {
            return View();
        }
    }
}
