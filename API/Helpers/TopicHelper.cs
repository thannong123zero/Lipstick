using API.Repositories;
using AutoMapper;
using SharedLibrary.DTO;
using SharedLibrary.UserInterfaceDTO;

namespace API.Helpers
{
    public class TopicHelper
    {
        private UnitOfWork _unitOfWork;
        private IMapper _mapper;
        public TopicHelper(IMapper mapper, UnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;

        }
        public async Task<IEnumerable<TopicUI>> GetTopics()
        {
            var listTopic = await _unitOfWork.TopicRepository.GetAll();
            if (listTopic == null)
            {
                return null;
            }
            listTopic = listTopic.OrderBy(s => s.Priority).ThenByDescending(s => s.ModifiedOn);
            IEnumerable<TopicUI> listTopicUI = new List<TopicUI>();
            listTopicUI = _mapper.Map<IEnumerable<TopicUI>>(listTopic);

            return listTopicUI;
        }
        public async Task<TopicUI> GetTopicByID(string ID)
        {
            if (!Guid.TryParse(ID, out var id))
            {
                return null;
            }
            var topic = await _unitOfWork.TopicRepository.GetById(Guid.Parse(ID));
            TopicUI topicUI = _mapper.Map<TopicUI>(topic);
            return topicUI;
        }
        public async Task AddTopic(TopicUI model)
        {
            try
            {
                Topic entity = _mapper.Map<Topic>(model);
                entity.ID = Guid.NewGuid();
                await _unitOfWork.TopicRepository.Create(entity);
                _unitOfWork.Save();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task UpdateTopic(TopicUI model)
        {
            try
            {
                Topic topic = await _unitOfWork.TopicRepository.GetById(model.ID);
                if (topic == null)
                {
                    return;
                }
                topic.NameEN = model.NameEN;
                topic.NameVN = model.NameVN;
                topic.DescriptionEN = model.DescriptionEN;
                topic.DescriptionVN = model.DescriptionVN;
                topic.ModifiedOn = DateTime.Now;
                topic.IsActive = model.IsActive;
                topic.Priority = model.Priority;
                topic.IsDeleted = model.IsDeleted;
                _unitOfWork.Save();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task<bool> DeleteTopicByID(string ID)
        {
            Topic topic = await _unitOfWork.TopicRepository.GetById(Guid.Parse(ID));

            if (topic != null && topic.Articles.Count <= 0)
            {
                await _unitOfWork.TopicRepository.Delete(Guid.Parse(ID));
                _unitOfWork.Save();
                return true;
            }
            return false;
        }
        public async Task<bool> SoftDeleteTopicByID(string ID)
        {
            var topic = await _unitOfWork.TopicRepository.GetById(Guid.Parse(ID));
            if (topic != null && topic.Articles.Count <= 0)
            {
                topic.IsDeleted = true;
                topic.ModifiedOn = DateTime.Now;
                //await _unitOfWork.TopicRepository.Update(topic);
                _unitOfWork.Save();
                return true;
            }
            return false;
        }
        public async Task<bool> CheckPermissionToDelete(string ID)
        {
            if (!Guid.TryParse(ID, out var id))
            {
                return false;
            }
            Topic topic = await _unitOfWork.TopicRepository.GetById(Guid.Parse(ID));

            if (topic != null && topic.Articles.Count <= 0)
            {
                return true;
            }
            return false;
        }
        public async Task RestoreTopicByID(string ID)
        {
            var topic = await _unitOfWork.TopicRepository.GetById(Guid.Parse(ID));
            if (topic != null)
            {
                topic.IsDeleted = false;
                topic.ModifiedOn = DateTime.Now;
                _unitOfWork.Save();
            }
        }
    }
}
