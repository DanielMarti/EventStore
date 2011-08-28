namespace EventStore.Dispatcher
{
	using System;

	/// <summary>
	/// Indicates the ability to dispatch or publish all messages associated with a particular commit.
	/// </summary>
	/// <remarks>
	/// Instances of this class must be designed to be multi-thread safe such that they can be shared between threads.
	/// </remarks>
	public interface IDispatchCommits : IDisposable
	{
		/// <summary>
		/// Dispatches the series of messages contained within the commit provided to all interested parties.
		/// </summary>
		/// <param name="commit">The commit representing the series of messages to dispatch.</param>
		void Dispatch(Commit commit);
	}
}