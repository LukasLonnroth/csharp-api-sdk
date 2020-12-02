using FortnoxAPILibrary.Entities;

using System.Threading.Tasks;

// ReSharper disable UnusedMember.Global

namespace FortnoxAPILibrary.Connectors
{
    /// <remarks/>
    public class ProjectConnector : SearchableEntityConnector<Project, ProjectSubset, ProjectSearch>, IProjectConnector
	{

        /// <remarks/>
		public ProjectConnector()
		{
			Resource = "projects";
		}

		/// <summary>
		/// Find a project based on id
		/// </summary>
		/// <param name="id">Identifier of the project to find</param>
		/// <returns>The found project</returns>
		public Project Get(string id)
		{
			return GetAsync(id).GetResult();
		}

		/// <summary>
		/// Updates a project
		/// </summary>
		/// <param name="project">The project to update</param>
		/// <returns>The updated project</returns>
		public Project Update(Project project)
		{
			return UpdateAsync(project).GetResult();
		}

		/// <summary>
		/// Creates a new project
		/// </summary>
		/// <param name="project">The project to create</param>
		/// <returns>The created project</returns>
		public Project Create(Project project)
		{
			return CreateAsync(project).GetResult();
		}

		/// <summary>
		/// Deletes a project
		/// </summary>
		/// <param name="id">Identifier of the project to delete</param>
		public void Delete(string id)
		{
			DeleteAsync(id).GetResult();
		}

		/// <summary>
		/// Gets a list of projects
		/// </summary>
		/// <returns>A list of projects</returns>
		public EntityCollection<ProjectSubset> Find()
		{
			return FindAsync().GetResult();
		}

		public async Task<EntityCollection<ProjectSubset>> FindAsync()
		{
			return await BaseFind().ConfigureAwait(false);
		}
		public async Task DeleteAsync(string id)
		{
			await BaseDelete(id).ConfigureAwait(false);
		}
		public async Task<Project> CreateAsync(Project project)
		{
			return await BaseCreate(project).ConfigureAwait(false);
		}
		public async Task<Project> UpdateAsync(Project project)
		{
			return await BaseUpdate(project, project.ProjectNumber).ConfigureAwait(false);
		}
		public async Task<Project> GetAsync(string id)
		{
			return await BaseGet(id).ConfigureAwait(false);
		}
	}
}
