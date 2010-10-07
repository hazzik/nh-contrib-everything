﻿using System;
using System.Collections;
using NHibernate.Envers.Query;

namespace NHibernate.Envers
{
    public interface IAuditReader {
        /**
         * Find an entity by primary key at the given revision.
         * @param primaryKey Primary key of the entity.
         * @param revision Revision in which to get the entity.
         * @return The found entity instance at the given revision (its properties may be partially filled
         * if not all properties are audited) or null, if an entity with that id didn't exist at that
         * revision.
         * @throws IllegalArgumentException If cls or primaryKey is null or revision is less or equal to 0.
         * @throws NotAuditedException When entities of the given class are not audited.
         * @throws IllegalStateException If the associated entity manager is closed.
         */
        T Find<T>(Object primaryKey, long revision);

        object Find(System.Type cls, object primaryKey, long revision);

        /**
         * Get a list of revision numbers, at which an entity was modified.
         * @param cls Class of the entity.
         * @param primaryKey Primary key of the entity.
         * @return A list of revision numbers, at which the entity was modified, sorted in ascending order (so older
         * revisions come first).
         * @throws NotAuditedException When entities of the given class are not audited.
         * @throws IllegalArgumentException If cls or primaryKey is null.
         * @throws IllegalStateException If the associated entity manager is closed.
         */
        //ORIG: List<Number>
        IList GetRevisions(System.Type cls, Object primaryKey);

        /**
         * Get the date, at which a revision was created.
         * @param revision Number of the revision for which to get the date.
         * @return Date of commiting the given revision.
         * @throws IllegalArgumentException If revision is less or equal to 0.
         * @throws RevisionDoesNotExistException If the revision does not exist.
         * @throws IllegalStateException If the associated entity manager is closed.
         */
        DateTime GetRevisionDate(long revision);

        /**
         * Gets the revision number, that corresponds to the given date. More precisely, returns
         * the number of the highest revision, which was created on or before the given date. So:
         * <code>getRevisionDate(GetRevisionNumberForDate(date)) <= date</code> and
         * <code>getRevisionDate(GetRevisionNumberForDate(date)+1) > date</code>.
         * @param date Date for which to get the revision.
         * @return Revision number corresponding to the given date.
         * @throws IllegalStateException If the associated entity manager is closed.
         * @throws RevisionDoesNotExistException If the given date is before the first revision.
         * @throws IllegalArgumentException If <code>date</code> is <code>null</code>.
         */
        long GetRevisionNumberForDate(DateTime date);

        /**
         * A helper method; should be used only if a custom revision entity is used. See also {@link RevisionEntity}.
         * @param revisionEntityClass Class of the revision entity. Should be annotated with {@link RevisionEntity}.
         * @param revision Number of the revision for which to get the data.
         * @return Entity containing data for the given revision.
         * @throws IllegalArgumentException If revision is less or equal to 0 or if the class of the revision entity
         * is invalid.
         * @throws RevisionDoesNotExistException If the revision does not exist.
         * @throws IllegalStateException If the associated entity manager is closed.
         */
        T FindRevision<T>(System.Type revisionEntityClass, long revision);

        /**
	     * Gets an instance of the current revision entity, to which any entries in the audit tables will be bound.
	     * Please note the if {@code persist} is {@code false}, and no audited entities are modified in this session,
	     * then the obtained revision entity instance won't be persisted. If {@code persist} is {@code true}, the revision
	     * entity instance will always be persisted, regardless of whether audited entities are changed or not.
	     * @param revisionEntityClass Class of the revision entity. Should be annotated with {@link RevisionEntity}.
	     * @param persist If the revision entity is not yet persisted, should it become persisted. This way, the primary
	     * identifier (id) will be filled (if it's assigned by the DB) and available, but the revision entity will be
	     * persisted even if there are no changes to audited entities. Otherwise, the revision number (id) can be
	     * {@code null}.
	     * @return The current revision entity, to which any entries in the audit tables will be bound.
	     */
        T GetCurrentRevision<T>(System.Type revisionEntityClass, bool persist);

        /**
         *
         * @return A query creator, associated with this AuditReader instance, with which queries can be
         * created and later executed. Shouldn't be used after the associated Session or EntityManager
         * is closed.
         */
        AuditQueryCreator CreateQuery();
    }
}